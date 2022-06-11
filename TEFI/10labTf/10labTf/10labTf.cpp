#include <windows.h>
#include <iostream>
#include <string>
#include <vector>
#include <stack>
#include <cstdlib>
#include <sstream>
#include <algorithm>
using namespace std;

static int code[256];
string operations[4] = { "XOR","AND","NOT","OR" };
struct Token
{
	char type;
	double number;
};



void InitCode();
double Execute(vector<Token>& exp);
void PrintVectorOfTokens(vector<Token>& vs);
vector<Token> ExpressionConverter(string& exp);
string mainstr;
string mainstrHead;
void PrintVectorOfTokens(vector<Token>& vs)
{
	vector<Token>::iterator it;

	for (it = vs.begin(); it != vs.end(); it++)
	{
		string change_str;
		if (it->type == 'n')
			cout << it->number << ' ';

		else {

			if (it->type == '<') {
				change_str = "XOR";
			}
			if (it->type == '&') {
				change_str = "AND";
			}
			if (it->type == '|') {
				change_str = "OR";
			}
			if (it->type == '~') {
				change_str = "NOT";
			}
			cout << change_str << ' ' << endl;
		}
			

	}
}
void to_assembler(string s)
{
	string buf;
	stringstream ss(s);
	vector<string> fplist;
	string arr[] = { "==", "!=", ">", "<", "+", "-", "*", "/", "=", ";","^","&","|","~"};
	vector<string> vect(arr, arr + (sizeof(arr) / sizeof(arr[0])));

	int store = 0;
	int lvl = 0;
	int then = 0;
	int el = 0;
	int add = 0;
	int sub = 0;
	int or1 = 0;
	int and1 = 0;
	int not1 = 0;
	string a;
	string b;
	while (ss >> buf) {
		fplist.push_back(buf);
	}

	for (int i = 0; i < fplist.size(); i++) {
		if (fplist[i] == ";")
		{
			lvl = 1;
		}
		else if (find(vect.begin(), vect.end(), fplist[i]) == vect.end())
		{
			if (lvl == 1)
				cout << "     ";
			if (store == 1 || lvl == 0)
			{
				cout << "LOAD " << fplist[i] << endl;
				store = 0;
			}
			else if (add == 1) {
				cout << "ADD " << fplist[i] << endl;
				add = 0;
			}
			else if (sub == 1) {
				cout << "SUB " << fplist[i] << endl;
				sub = 0;
			}
			else
			{
				cout << "STORE " << fplist[i] << endl;
			}
		}
		else if (fplist[i] == "=")
		{
			store = 1;
		}
		else if (fplist[i] == "^")
		{
			/*if (then == 0)
			{
				cout << "CMP: " << a << " " << b << endl;
				cout << "JNZ JMP THEN " << endl;
				if (el == 1)
					cout << "JMP ELSE" << endl;
				cout << "THEN:" << endl;
				then++;
			}*/
			lvl = 1;
		}
		else if (fplist[i] == "|")
		{
			if (then == 0)
			{
				cout << "OR: " << a << " " << b << endl;
			
				then++;
			}
			lvl = 1;
		}
		else if (fplist[i] == "&")
		{
			if (then == 0)
			{
				cout << "AND : " << a << " " << b << endl;
				then++;
			}
			lvl = 1;
		}
		else if (fplist[i] == "~")
		{
			if (then == 0)
			{
				cout << "NOT: " << " " << b << endl;
			
				then++;
			}
			lvl = 1;
		}
		else if (find(vect.begin(), vect.end(), fplist[i]) != vect.end())
		{
			if (fplist[i] == "+") {
				add = 1;
				lvl = 1;
			}
				
			if (fplist[i] == "-") {
				sub = 1;
				lvl = 1;
			}
				
		}
	}
	cout << "\n\n\n" << endl;
}

void to_optimize_assembler(string s) {
		string buf;
		stringstream ss(s);
		vector<string> fplist;
		string arr[] = { "==", "!=", ">", "<", "+", "-", "*", "/", "=", ";","^","&","|","~"};
		vector<string> vect(arr, arr + (sizeof(arr) / sizeof(arr[0])));

		int store = 0;
		int lvl = 0;
		int then = 0;
		int el = 0;
		int add = 0;
		int sub = 0;
		int or1 = 0;
		int and1 = 0;
		int not1 = 0;
		string a;
		string b;
		bool is_optimize = false;
		while (ss >> buf) {
			fplist.push_back(buf);
		}

		for (int i = 0; i < fplist.size(); i++) {
			if (fplist[i] == ";")
			{
				lvl = 1;
			}
			else if (fplist[i] == "(" || fplist[i] == ")") {
				continue;
			}
			else if (find(vect.begin(), vect.end(), fplist[i]) == vect.end())
			{
				if (lvl == 1)
					cout << "     ";
				if (store == 1 || lvl == 0)
				{
					if (fplist[i + 1] == "+") {
						is_optimize = true;
						cout << "LOAD B" << fplist[i+2] << endl;
					}
					else {
						cout << "LOAD " << fplist[i] << endl;
					}
					store = 0;
				}
				else if (add == 1) {
					if (is_optimize) {
						cout << "ADD A " << fplist[i-2] << endl;
					}
					else {
						cout << "ADD " << fplist[i] << endl;
					}
					
					add = 0;
				}
				else if (sub == 1) {
					cout << "SUB " << fplist[i] << endl;
					sub = 0;
				}
				else
				{
					cout << "STORE " << fplist[i] << endl;
				}
			}
			else if (fplist[i] == "=")
			{
				store = 1;
			}
			else if (fplist[i] == "&")
			{
			
					cout << "XOR: " << a << " " << b << endl;
				lvl = 1;
			}
			else if (fplist[i] == "|")
			{
				if (then == 0)
				{
					cout << "OR: " << a << " " << b << endl;

					then++;
				}
				lvl = 1;
			}
			else if (fplist[i] == "&")
			{
				if (then == 0)
				{
					cout << "AND : " << a << " " << b << endl;
					then++;
				}
				lvl = 1;
			}
			else if (fplist[i] == "~")
			{
				if (then == 0)
				{
					cout << "NOT: " << " " << b << endl;

					then++;
				}
				lvl = 1;
			}
			else if (find(vect.begin(), vect.end(), fplist[i]) != vect.end())
			{
				if (fplist[i] == "+") {
					add = 1;
					lvl = 1;
				}

				if (fplist[i] == "-") {
					sub = 1;
					lvl = 1;
				}

			}
		}
		cout << "\n\n\n" << endl;
	

}
/* вычисляет выражение */
double Execute(vector<Token>& exp)
{
	vector<Token>::iterator it;
	stack<double> math_stack;
	int one, two, result=0;

	for (it = exp.begin(); it != exp.end(); it++)
	{
		if (it->type == 'n') // все числа в стек пихаем
		{
			math_stack.push(it->number);
			continue;
		}

		// как только встетили операцию, достаем из стека пару чисел и
		one = math_stack.top(); // "оперируем" их. Результат опять в стек.
		math_stack.pop();
		two = math_stack.top();
		math_stack.pop();

		switch (it->type)
		{
		case '+':
			result = two + one;
			break;
		case '-':
			result = two - one;
			break;
		case '*':
			result = two * one;
			break;
		case '/':
			result = two / one;
			break;
		case '>':
			result = two<<one;
			break;
		case'<':
			result = two << one;
			break;
		case'^':
			result = two ^ one;
			break;
		case'|':
			result = two | one;
			break;
		}

		math_stack.push(result);
	}

	// результат всегда на верху стека.
	// но если у нас пустое выражение, то результата может и не быть ^_^
	return math_stack.empty() ? 0 : math_stack.top();
}


/*
std::size_t found = str.find_first_of("aeiou");
  while (found!=std::string::npos)
  {
	str[found]='*';
	found=str.find_first_of("aeiou",found+1);
  }

*/
void replace_or_merge(std::string& a, const std::string& b, const std::string& c) {
	const std::string::size_type pos_b_in_a = a.find(b); 
	string change_str;
	if (pos_b_in_a == std::string::npos) { 
		a.insert(0, c); 
	} else { 
		if (b == "XOR") {
			change_str = '<';
		}
		if (b == "AND") {
			change_str = "&";
		}
		if (b == "OR") {
			change_str = "|";
		}
		if (b == "NOT") {
			change_str = "~";
		}
		a.replace(pos_b_in_a, b.length(), change_str);
	} 
}

/* конвертирует обычное выражение в польскую запись */
vector<Token> ExpressionConverter(string& exp,string& s)
{
	string::iterator it,it1, begin;
	vector<Token> result;
	stack<char> expstack;
	Token t;
	string expNew,exp1 ;

	for (int x = 0; x < 5;x++) {
			replace_or_merge(exp, operations[x], mainstr);
	}
	s = exp;
	exp.erase(0, exp.find_first_of("=") + 1);

	for (it = exp.begin(); it != exp.end(); it++)
	{
		if (!isdigit(*it) && !strchr("+-*/()<&^|~", *it))
			continue;

		if (isdigit(*it))
		{
			begin = it;
			for (; it != exp.end(); it++)
			{
				if (!isdigit(*it))
					break;
			}
			t.number = atof(string(begin, it).c_str());
			t.type = 'n'; // n означает число 
			result.push_back(t);

			it--; // костыль
			continue;
		}
		else
		{
			if (expstack.empty()) // в пустой стек пихам всегда
			{
				expstack.push(*it);
				continue;
			}

			if (*it == '(') // скобку наверх
			{
				expstack.push(*it);
				continue;
			}

			if (*it == ')') // выталкиваем все до открывающей скобки.
			{ // сами скобки уничтожаем
				while (expstack.top() != '(')
				{
					t.type = expstack.top();
					result.push_back(t);
					expstack.pop();
				}

				expstack.pop();
				continue;
			}
			// заталкиваем операцию в стек в зависимости от приоритета
			while (!expstack.empty() && code[expstack.top()] >= code[*it])
			{
				t.type = expstack.top();
				result.push_back(t);
				expstack.pop();
			}

			expstack.push(*it);
		}
	}
	// выталкиваем все что осталось
	while (!expstack.empty())
	{
		t.type = expstack.top();
		result.push_back(t);
		expstack.pop();
	}

	return result;
}
void InitCode()
{
	code['*'] = 3;
	code['/'] = 3;
	code['+'] = 2;
	code['-'] = 2;
	code['('] = 1;
	code[')'] = 0;
	code['^'] = 3;
	code['<'] = 3;
	code['>'] = 3;
	code['~'] = 3;
	code['|'] = 3;
	code['&'] = 3;
}
int main()
{
	string exp;
	vector<Token> pol;

	InitCode();

	while ("I love Java")
	{
		cout << "Enter expression: ";
		getline(cin, exp);
		string res;
		pol = ExpressionConverter(exp,res);

		cout << "Converted expression: ";
		PrintVectorOfTokens(pol);
		cout << endl << "Result: " << Execute(pol) << endl;
		to_assembler(exp);
		to_optimize_assembler(exp);
	}

	return 0;
}

