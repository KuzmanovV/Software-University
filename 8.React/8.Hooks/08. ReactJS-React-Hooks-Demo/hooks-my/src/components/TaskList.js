import TaskItem from "./TaskItem";

export default function TaskList({
    tasks,
    taskDeleteHandler,
}) {
    return (
        <ul>
            {tasks.map(x => 
                <TaskItem 
                    key={x._id} 
                    taskId={x._id}
                    title={x.title} 
                    taskDeleteHandler={taskDeleteHandler}
                />
            )}
        </ul>
    )
}