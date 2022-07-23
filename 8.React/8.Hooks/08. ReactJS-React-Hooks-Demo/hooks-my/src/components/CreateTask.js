import { useState } from "react";

export default function CreateTask({
    taskCreateHandler
}) {
  const [task, setTask] = useState("");

  const onSubmit = (e) => {
    e.preventDefault();
    taskCreateHandler(task);
    setTask('');
  };

  const onChange = (e) => {
    setTask(e.target.value);
  }

  return (
    <form onSubmit={onSubmit}>
      <input 
        type="text" 
        name="taskName" 
        placeholder="Do the dishes" 
        value={task}
        onChange={onChange}
      />
      <input type="submit" value="Add" />
    </form>
  );
}
