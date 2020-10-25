# https://www.codewars.com/kata/5f6d533e1475f30001e47514/train/python

# You are given a list of unique integers arr, and two integers a and b. Your task is to find out whether or not a and b appear consecutively in arr, and return a boolean value (True if a and b are consecutive, False otherwise). It is guaranteed that a and b are both present in arr.


def consecutive(arr, a, b):
    return arr.index(a) - arr.index(b) == 1 or arr.index(b) - arr.index(a) == 1
