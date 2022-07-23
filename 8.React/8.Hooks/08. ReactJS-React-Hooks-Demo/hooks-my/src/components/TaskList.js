import TaskItem from "./TaskItem";

export default function TaskList({tasks}) {
    return (
        <ul>
            {tasks.map(x => <TaskItem key={x._id} title={x.title}/>)}
        </ul>
    )
}