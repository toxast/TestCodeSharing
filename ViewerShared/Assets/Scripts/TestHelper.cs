using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TestHelper 
{
    public static int Add(int a, int b) {
        return a + b;
    }

    public static int Substract(int a, int b) {
        return a - b;
    }

    public static int Max(int a, int b) {
        return Mathf.Max(a, b);
    }
}
