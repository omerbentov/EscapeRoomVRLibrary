using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleManager
{
    private enum State {Initial, FirstCompleted,
                        SecondCompleted, ThirdCompleted};

    private static RiddleManager _instance;
    private State _state;

    private RiddleManager() {
        _state = State.Initial;
    }

    public static RiddleManager Instance() {
        if (_instance == null) {
            _instance = new RiddleManager();
        }

        return _instance;
    }

    public void OnFirstCompleted() {
        if (_state == State.Initial) {
            _state = State.FirstCompleted;
        }
    }

    public void OnSecondCompleted() {
        if (_state == State.FirstCompleted) {
            _state = State.SecondCompleted;
        }
    }

    public void OnThirdCompleted() {
        if (_state == State.SecondCompleted) {
            _state = State.ThirdCompleted;
        }
    }

    public bool IsInitialState() {
        return _state == State.Initial;
    }
    public bool IsLevelCompleted() {
        return _state == State.ThirdCompleted;
    }
}
