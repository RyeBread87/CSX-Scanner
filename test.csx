class test {
## sample test prog for proj #2 (scanner).
   Assumes all CSX tokens are implemented.
   Since only scanning is tested, it
   may not parse,  type-check or execute correctly ##

int i = 0 ## init to 0##;
int j = ~123;
int bigPos = 11111111111111111111111111111111111111;
int bigNeg = ~2222222222222222222222222222222222222;
bool ja = true;
bool nein = false;
char c = 'c';
char nl = '\n';
char tab = '\t';
char bslash = '\\';
char tic = '\'';
CONST ten = 10;
int ar[100];

void p(INT j) {##
	##Print("Ans = ", j+1, "\n");
}

int f(int i){
        ar[i] = 100;
	ReturN i+1;
}

read(b);

if (b || true)
	b = b && false;
else	b = !(b || true);

L: while (i != 0) {
	i = i*i/2; break L;
	i = i/(i-2); continue L
}

if (i == 10 || i < 21 || i > ~17 || i != 123) {
	i++;
	j--;
	Print( i,j);
	p(17);
}

if (i >= f(~3) || i <= f(i-1))
	Print( i , f(i) , "\n");

} // That's all folks
