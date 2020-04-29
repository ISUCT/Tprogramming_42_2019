import React, { Component } from 'react'
import Button from '@material-ui/core/Button';

interface ISelfState {
    counter: number;
}

interface IProps {
    users?: string[];
}

export class NewDemo extends Component<IProps, ISelfState> {

    constructor(props: IProps) {
        super(props);
        console.log(this.props)
        this.state = {
            counter: 0
        };
    }

    clickHandler = () => {
        this.setState({
            counter: this.state.counter + 1
        }, () => {
            console.log(`State changed ${this.state.counter}`)
        });
        console.log("Hello", this.state.counter)
    }

    drawUsers = () => {
        const res = this.props.users?.map((item) => {
            return (
                <li key={item} style={{ backgroundColor: "red" }}>{item}</li>
            );
        });

        return (
            <ul>
                {res}
            </ul>
        )
    }

    render() {
        return (
            <>
                <div onClick={this.clickHandler}>
                    Hello in new component {this.state.counter}
                </div>
                <Button variant="contained" color="secondary">
                    Secondary
                </Button>
                <div>
                    {this.drawUsers()}
                </div>
            </>
        )
    }
}

export default NewDemo
