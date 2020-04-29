import React, { Component } from 'react'

export default class MyComponent extends Component<any, any> {

    constructor(props: any) {
        super(props);
        this.state = {
            count: 0,
        }
    }

    onClickHandler = () => {
        console.log("Before", this.state.count)
        this.setState({count: this.state.count + 1});
        console.log("After", this.state.count)
    }

    render() {
        return (
            <div onClick={this.onClickHandler}>
                Hello from component {this.state.count}
            </div>
        )
    }
}
