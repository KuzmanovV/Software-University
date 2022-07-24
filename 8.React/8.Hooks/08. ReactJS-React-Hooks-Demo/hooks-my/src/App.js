import TaskList from "./components/TaskList";
import styles from './App.module.css';
import CreateTask from "./components/CreateTask";
import useFetch from './hooks/useFetch';

function App() {
  // const[tasks, setTasks] = useState([
  //   {_id: 1, title: 'first'},
  //   {_id: 2, title: 'second'},
  //   {_id: 3, title: 'third'},
  // ]);

  const [tasks, setTasks, isLoading] = useFetch('http://localhost:3030/jsonstore/todos', [])

  const taskCreateHandler = (newTask) => {
    setTasks(state => [...state, {_id: state[state.length-1]._id+1, title: newTask}]);
  }

  const taskDeleteHandler = (taskId) => {
    setTasks(state => state.filter(x => x._id != taskId));
  }
  
  return (
    <div className={styles['site-wrapper']}>
      <header>
        <h1>TODO App</h1>
      </header>
      <main>
        {isLoading
          ? <p>Loading...</p>
          : <TaskList tasks={tasks} taskDeleteHandler={taskDeleteHandler}/>
        }


        <CreateTask taskCreateHandler={taskCreateHandler}/>
      </main>
    </div>
  );
}

export default App;
