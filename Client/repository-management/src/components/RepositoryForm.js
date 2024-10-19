// src/components/RepositoryForm.js
import React, { useState } from "react";
import axios from "axios";

function RepositoryForm({ fetchRepositories }) {
  const [title, setTitle] = useState("");
  const [isPublic, setIsPublic] = useState(true);

  const handleSubmit = async (e) => {
    e.preventDefault();

    // Мокаем данни за автора (OwnerId)
    const newRepository = {
      title,
      isPublic,
      ownerId: 1, // Можете да замените с фиктивен потребителски ID
    };

    try {
      await axios.post(
        "https://localhost:7029/api/Repositories",
        newRepository
      );
      setTitle("");
      setIsPublic(true);
      fetchRepositories();
    } catch (error) {
      console.error("Error creating repository:", error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <h3>Create New Repository</h3>
      <div>
        <label>Title:</label>
        <input
          type="text"
          required
          value={title}
          onChange={(e) => setTitle(e.target.value)}
        />
      </div>
      <div>
        <label>
          <input
            type="checkbox"
            checked={isPublic}
            onChange={(e) => setIsPublic(e.target.checked)}
          />
          Public
        </label>
      </div>
      <button type="submit">Create Repository</button>
    </form>
  );
}

export default RepositoryForm;
