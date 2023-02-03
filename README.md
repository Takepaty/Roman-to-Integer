# Roman-to-Integer

Os algarismos romanos são representados por sete símbolos diferentes  : I, V, X, L, C, D e M.

Symbol|Value |
------|------|
  I   | 1    |
  V   | 5    |     
  X   | 10   |
  L   | 50   |
  C   | 100  |  
  D   | 500  |
  M   | 1000 |  
  
  Por exemplo,  2 é escrito como II em algarismo romano, apenas dois somados. 12 é escrito como  XII, que é simplesmente X + II. O número 27 é escrito como XXVII, que é XX + V + II.

Os algarismos romanos geralmente são escritos do maior para o menor, da esquerda para a direita. No entanto, o numeral para quatro não é IIII. Em vez disso, o número quatro é escrito como IV. Como o um vem antes do cinco, nós o subtraímos, resultando em quatro. O mesmo princípio se aplica ao número nove, que é escrito como IX. Existem seis instâncias em que a subtração é usada:

I pode ser colocado antes de V  (5) e X (10) para fazer 4 e 9. 

X pode ser colocado antes de L (50) e C (100) para fazer 40 e 90. 

C pode ser colocado antes de D (500) e M (1000) para fazer 400 e 900.

Dado um numeral romano, converta-o para um número inteiro.

### EXEMPLO 1:

ENTRADA|SAÍDA |
-------|------|
  III  | 3    |  

  EXPLICAÇÃO: III = 3.

### EXEMPLO 2:

ENTRADA |SAÍDA |
--------|------|
  LVIII | 58   |

  EXPLICAÇÃO: L = 50, V = 5, III = 3. 

### EXEMPLO 3:
  
   ENTRADA | SAÍDA  |
 ----------|--------|
   MCMXCIV | 1994   |

  EXPLICAÇÃO: M = 1000, CM = 900, XC = 90, IV = 4. 

Restrições:

1 <= s.length <= 15

scontém apenas os caracteres ('I', 'V', 'X', 'L', 'C', 'D', 'M').
É garantido  que sé um numeral romano válido no intervalo [1, 3999].
  
