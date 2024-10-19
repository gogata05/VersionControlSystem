// src/components/RepositoryList.js
import React, { useState, useEffect } from "react";
import axios from "axios";
import RepositoryForm from "./RepositoryForm";

function RepositoryList() {
  const [repositories, setRepositories] = useState([]);
  const [searchTitle, setSearchTitle] = useState("");

  // Fetch all repositories when the component mounts
  useEffect(() => {
    fetchRepositories();
  }, []);

  const fetchRepositories = async () => {
    try {
      // Prepare query parameters
      const params = {};
      if (searchTitle.trim() !== "") {
        params.search = searchTitle;
      }
      const response = await axios.get(
        "https://localhost:7029/api/Repositories",
        {
          params: params,
        }
      );
      setRepositories(response.data);
    } catch (error) {
      console.error("Error fetching repositories:", error);
    }
  };

  const handleDelete = async (id) => {
    try {
      await axios.delete(`https://localhost:7029/api/Repositories/${id}`);
      fetchRepositories();
    } catch (error) {
      console.error("Error deleting repository:", error);
    }
  };

  const handleSearchChange = (e) => {
    setSearchTitle(e.target.value);
  };

  const handleSearch = () => {
    fetchRepositories();
  };

  return (
    <div>
      <h2>Repositories</h2>
      <div className="search-container">
        <input
          type="text"
          placeholder="Search by title..."
          value={searchTitle}
          onChange={handleSearchChange}
        />
        <button onClick={handleSearch}>Search</button>
      </div>
      <RepositoryForm fetchRepositories={fetchRepositories} />
      <ul>
        {repositories.map((repo) => (
          <li key={repo.id}>
            <span>
              {repo.title} - {repo.isPublic ? "Public" : "Private"}
            </span>
            <button onClick={() => handleDelete(repo.id)}>Delete</button>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default RepositoryList;
