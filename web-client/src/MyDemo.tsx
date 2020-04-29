import React, { Component } from 'react'

export default class MyDemo extends Component<any, any> {

    constructor(props: any){
        super(props);
        this.state = {
            counter: 0
        }
    }

    clickHandler = () => {
        this.setState({
            counter: this.state.counter + 1
        });
        console.log("hello", this.state.counter);
    }

    render() {
        return (
            <div style={{backgroundColor:"blue"}} onClick={this.clickHandler}>
                Hello from component {this.state.counter}             
            </div>
        )
    }
}
