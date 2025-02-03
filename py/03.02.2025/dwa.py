#  *args - zbiór argumentów nieskończonych 
#  **dict_args - zbiór klucz wartość

def fn1(a,*args):
    print(a)
    print(args)
    print(args[0])

#fn1(2,2,3,4,5,67,3,45,67,89, True, 'Sigiemka', 'Arek', 12.123)

def fn2(a,*args,**dict_args):
    print(a)
    print(args)
    print(args[0])
    print(dict_args)

#fn2(2,2,3,4,5,67,3,45,67,89, True, 'Sigiemka', 'Arek', 12.123, imie='Arek', wiek=45)

def dod(a,b):
    return a + b
wynik = dod(3,5)
print(wynik)

def fn3(a,*args,**dict_args):
    for el in args:
        print(el)
    for key, value in dict_args:
        print(key, value)


fn3(2,2,3,4,5,67,3,45,67,89, True, 'Sigiemka', 'Arek', 12.123, imie='Arek', wiek=45)