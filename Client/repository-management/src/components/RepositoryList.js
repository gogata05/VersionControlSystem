// src/RepositoryList.js
import React, { useState, useEffect } from "react";
import axios from "axios";
import RepositoryForm from "./RepositoryForm";

function RepositoryList() {
  const [repositories, setRepositories] = useState([]);
  const [searchTitle, setSearchTitle] = useState("");

  useEffect(() => {
    fetchRepositories();
  }, [searchTitle]);

  const fetchRepositories = async () => {
    try {
      const response = await axios.get(
        "https://localhost:7029/api/Repositories",
        {
          params: {
            search: searchTitle,
          },
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

  return (
    <div>
      <h2>Repositories</h2>
      <input
        type="text"
        placeholder="Search by title..."
        value={searchTitle}
        onChange={handleSearchChange}
      />
      <RepositoryForm fetchRepositories={fetchRepositories} />
      <ul>
        {repositories.map((repo) => (
          <li key={repo.id}>
            {repo.title} - {repo.isPublic ? "Public" : "Private"}
            <button onClick={() => handleDelete(repo.id)}>Delete</button>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default RepositoryList;
