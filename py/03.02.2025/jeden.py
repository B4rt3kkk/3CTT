def fn():
    print("Hello this is me Patrick Texas")

def fn_parametry(a,b):
    print(a,b)

fn_parametry(3,5)

def fn_par_domyslne(a=0,b=0):
    print(a+b)

#fn_par_domyslne()
#fn_par_domyslne(4,6)

def fn_argumenty_kluczowe(a,b=0,c=0):
    print('a:',a,'b:',b,'c:',c)

fn_argumenty_kluczowe(3,c=2,b=5)