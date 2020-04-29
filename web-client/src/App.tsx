import React from 'react';
import logo from './logo.svg';
import './App.css';
import MyComponent from './MyComponent';
import DemoComponent from './DemoComponent';
import MyDemo from './MyDemo';
import NewDemo from './NewDemo';

function App() {
  const users = ["Ivanov", "Petrov", "Sidorov"] 

  return (
    <>
      <div>Hello</div>
      <NewDemo users={users}/>
    </>
  );
}

export default App;
