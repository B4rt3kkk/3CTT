# tupla - struktura danych niemutowalna, brak edycji

mojaTupla1 = (1,2,3, 'abc', True, 123.25)

print(mojaTupla1)

print(mojaTupla1[2])

# mojaTupla1[0] = 10   -   to bydzie error bracje

print(mojaTupla1[:3])

print(mojaTupla1 * 2)

tumpla2 = (4,5,6,7,8,9)

print("SUM = ", sum(tumpla2))

print("MIN = ", min(tumpla2))

print("MAX = ", max(tumpla2))

tuple_A = (1,2,3,4,5,"Arek to SIGMA")
a,b,c,d,e,f = tuple_A
print(a,b,c,d,e,f)  # 1 2 3 4 5