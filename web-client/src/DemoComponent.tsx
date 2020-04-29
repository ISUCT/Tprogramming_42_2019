import React, { Component } from 'react'

interface IProps {
    users: string[];
}

interface ISelfState {
    counter: number;
    name?: string;
}

export class DemoComponent extends Component<IProps, ISelfState> {
    constructor(props: any) {
        super(props);
        this.state = {
            counter: 0
        }
    }

    clickHandler = () => {
        this.setState({
            counter: this.state.counter + 1
        });
        console.log("Hello", this.state.counter);
    }

    drawList = () => {
        return (
            <ul>
                {this.props.users.map((item: string) => {
                    return (
                        <li>{item}</li>
                    )
                })
                }
            </ul>
        )
    }

    render() {
        return (
            <div style={{ backgroundColor: "red" }} onClick={this.clickHandler}>
                Hello Demo Component {this.state.counter}
                <br />
                Hello:
                {this.drawList()}
            </div>
        )
    }
}

export default DemoComponent
