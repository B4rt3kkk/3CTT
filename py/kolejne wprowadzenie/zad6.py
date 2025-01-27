# Lekcja pod tytułem pentle

'''
counter = 0

while counter < 10:
    print(counter)
    counter += 1


# break oraz continue

licznik = 1 
while licznik <= 10:
    licznik+=1
    if licznik == 5:    
        break
    print(licznik)

licznik2 = 1
while licznik2 <= 10:   
    licznik2 += 1
    if licznik2 % 2 == 0:  
        continue
    print(licznik2)  # Ten print nie zostanie wykonany

'''

while True: 
    num = int(input("Podaj jakas liczbe wieksza od 0 bo inaczej wybombi pc: "))
    if num > 0: 
        print("Twoja liczba to ", num)
        break
    else:   
        print("Mowilem zebys nie pisal 0 ")