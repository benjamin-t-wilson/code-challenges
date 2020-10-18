#https://www.codewars.com/kata/5f8341f6d030dc002a69d7e4/train/python
#Given an array of numbers and an index, return the index of the least number
#larger than the element at the given index, or -1 if there is no such index (
#or, where applicable, Nothing or a similarly empty value ).

#Notes
#Multiple correct answers may be possible.  In this case, return any one of
#them.
#The given index will be inside the given array.
#The given array will, therefore, never be empty.

#Example
#least_larger( [4, 1, 3, 5, 6], 0 ) -> 3
#least_larger( [4, 1, 3, 5, 6], 4 ) -> -1

def least_larger(a, i): 
    list = [num for num in a if num > a[i]]
    return a.index(min(list)) if len(list) > 0 else -1

print(least_larger([4, 1, 3, 5, 6], 0), 3)
print(least_larger([4, 1, 3, 5, 6], 4), -1)
print(least_larger([1, 3, 5, 2, 4], 0), 3)