# Stack and Heap

## Value Type

Stack
+-------------+
| p1.X = 1    |
| p1.Y = 2    |
+-------------+
p1 stores its own values because Point is a value type

P2 = P1  
┌───────────────┐
│ p2            │
│ X = 1         │
│ Y = 2         │
└───────────────┘
p2 receives a separate copy of the values stored in p1.

After changing p2.X
p2.X = 99;

Stack
+-------------+
| p1.X = 1    |
| p1.Y = 2    |
+-------------+

+-------------+
| p2.X = 99   |
| p2.Y = 2    |
+-------------+
p2.X changed to 99, but p1.X stayed 1 because they are separate copies.

p1 and p2 have separate copies.


## Reference Type

STACK                 HEAP

o1 ────────────────► [ Order Object ]
                       IsPaid = false

o1 refers to an Order object stored on the heap.

After copying o1 to o2

Order o2 = o1;

STACK                 HEAP

o1 ──────────────-----------──┐
                         
o2 ─────────────────► [ Order Object ]
                        IsPaid = false

o2 receives a copy of the reference, so both variables refer to the same Order object.                   

After changing o2.IsPaid

  o2.IsPaid = true;

  
o1 ──────────────------──┐
                   
o2 ─────────────────► [ Order Object ]
                        IsPaid = true

Changing o2.IsPaid also changes o1 because they share the same object.
Reference → same object


What would be different with structs?
If Order were a struct instead of a class, it would be a value type like Point from Part C
so o2 = o1 would create a separate copy of the Order data rather than making both
variables refer to the same object.
