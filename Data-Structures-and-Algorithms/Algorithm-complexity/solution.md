#What is the expected running time of the following C# code? (Task 1)
![Task 1 code image](http://puu.sh/l7SN9/5affdb231b.png)
###Answer:
__Asuming a matrix of size n*m.__
For each iteration of the loop, a new iteration is made. Both iterations loop n times, so the complexity is O(n^2).

#What is the expected running time of the following C# code? (Task 2)
![Task 2 code image](http://puu.sh/l7SNQ/d9d8fc1fa5.png)
###Answer:
__Asuming a matrix of size n*m.__
####Worst case:
O(n * m) - if each [0] element of each row in the matrix is an even number.
####Average case:
O(n * n / 2) If half of the [0] elements of each row are even numbers.
####Best case:
 If no first element is an even number, then the complexity will be O(n).

#What is the expected running time of the following C# code? (Task 3)
![Task 3 code image](http://puu.sh/l7SOF/178e243080.png)
###Answer:
__Asuming a matrix of size n*m.__

####Best case: m(columns) <= n(rows)
The loop will iterate m times. The if statement will be false and the recursion won't start. The complexity will be O(m).
####Worst case: row = 0
The loop iterates m times. The if statement is true n - 1 times. The overall complexity is O(m * n). The sizes of n and m can vary, so we can have complexities like m^2 (when m = n - 1) and so on.
####Average case: row + 1 = matrix.GetLength(1) / 2
The loop iterates m times. The if statement is true n / 2 times, so the overall complexity is O(m * n / 2).
