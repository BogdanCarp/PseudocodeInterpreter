using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PseudocodeInterpreter.Tests
{
	public class LexerTests
	{
		[Fact]
		public void Test_Lexer_NextTokenInteger()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.NUMBER, langManager.Keywords.Number);
			
			var lexer = new Lexer("number test text 432", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenIntegerLit()
		{
			var langManager = new LanguageManager();
			const string integerLit = "343";
			var expected = new Token(TokenType.NumberLit, integerLit);
			var input = $"   {integerLit} integer test text";
			
			var lexer = new Lexer(input, langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenReal()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.NUMBER, langManager.Keywords.Number);
			
			var lexer = new Lexer(" number test text 44.55", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenRealLit()
		{
			var langManager = new LanguageManager();
			const string realLit = "44.55";
			var expected = new Token(TokenType.NumberLit, realLit);
			var input = $" {realLit} real test text";
			
			var lexer = new Lexer(input, langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenText()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.TEXT, langManager.Keywords.Text);
			
			var lexer = new Lexer(" text test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenTextLit()
		{
			var langManager = new LanguageManager();
			const string textLit = "\"weeee\"";
			var expected = new Token(TokenType.TextLit, "weeee");
			var input = $" {textLit} real test text  ";
			
			var lexer = new Lexer(input, langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenIf()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.IF, langManager.Keywords.If);
			
			var lexer = new Lexer(" if test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenThen()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.THEN, langManager.Keywords.Then);
			
			var lexer = new Lexer("then test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenElse()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.ELSE, langManager.Keywords.Else);
			
			var lexer = new Lexer("else test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenElseIf()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.ELSEIF, langManager.Keywords.ElseIf);
			
			var lexer = new Lexer("else if test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenWhile()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.WHILE, langManager.Keywords.While);
			
			var lexer = new Lexer("while test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenUntil()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.UNTIL, langManager.Keywords.Until);
			
			var lexer = new Lexer("until test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenTimes()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.TIMES, langManager.Keywords.Times);
			
			var lexer = new Lexer("times test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenDo()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.DO, langManager.Keywords.Do);
			
			var lexer = new Lexer("do test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenEnd()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.END, langManager.Keywords.End);
			
			var lexer = new Lexer("end test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenFunction()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.FUNCTION, langManager.Keywords.Function);
			
			var lexer = new Lexer("function test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenReturn()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.RETURN, langManager.Keywords.Return);
			
			var lexer = new Lexer("return test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenWrite()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.WRITE, langManager.Builtins.Write);
			
			var lexer = new Lexer("write test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenWriteLine()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.WRITELINE, langManager.Builtins.WriteLine);
			
			var lexer = new Lexer("writeLine test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenRead()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.READ, langManager.Builtins.Read);
			
			var lexer = new Lexer("read test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenToText()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.TOTEXT, langManager.Builtins.ToText);
			
			var lexer = new Lexer("toText test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}
		
		[Fact]
		public void Test_Lexer_NextTokenLength()
		{
			var langManager = new LanguageManager();
			var expected = new Token(TokenType.LENGTH, langManager.Builtins.Length);
			
			var lexer = new Lexer("length test \"text 44.55\"", langManager);
			
			Assert.Equal(expected.ToString(), lexer.GetNextToken().ToString());
		}

		[Fact]
		public void Test_Lexer_TokenStreamEn1()
		{
			var langManager = new LanguageManager();
			var expectedTokens = new List<Token>
			{
				new Token(TokenType.Dot, "."),
				new Token(TokenType.Pow, "**"),
				new Token(TokenType.Div, "/"),
				new Token(TokenType.NumberLit, "33"),
				new Token(TokenType.DivInt, "//"),
				new Token(TokenType.EOF, null)
			};
			
			var lexer = new Lexer(".** / 33//", langManager);
			
			var tokenList = new List<Token>();
			
			do
			{
				tokenList.Add(lexer.GetNextToken());
			} while (tokenList.Last().Type != TokenType.EOF);
			
			Assert.Equal(expectedTokens, tokenList);
		}

		[Fact]
		public void Test_Lexer_TokenStreamEn2()
		{
			var langManager = new LanguageManager();
			var expectedTokens = new List<Token>
			{
				new Token(TokenType.NUMBER, "number"),
				new Token(TokenType.Identifier, "a"),
				new Token(TokenType.NL, "\n"),
				new Token(TokenType.NL, "\n"),
				new Token(TokenType.IF, "if"),
				new Token(TokenType.NumberLit, "1"),
				new Token(TokenType.Plus, "+"),
				new Token(TokenType.NumberLit, "2"),
				new Token(TokenType.Equals, "=="),
				new Token(TokenType.NumberLit, "3"),
				new Token(TokenType.THEN, "then"),
				new Token(TokenType.NL, "\n"),
				new Token(TokenType.Identifier, "a"),
				new Token(TokenType.Assign, "="),
				new Token(TokenType.NumberLit, "3"),
				new Token(TokenType.NL, "\n"),
				new Token(TokenType.ELSE, "else"),
				new Token(TokenType.NL, "\n"),
				new Token(TokenType.Identifier, "a"),
				new Token(TokenType.Assign, "="),
				new Token(TokenType.NumberLit, "0"),
				new Token(TokenType.NL, "\n"),
				new Token(TokenType.END, "end"),
				new Token(TokenType.EOF, null)
			};

			const string text = "number a  \n\n" +
			                    "if 1 + 2 == 3 then\n" +
			                    "	a = 3\n" +
			                    "else\n" +
			                    "	a = 0\n" +
			                    "end";
			var lexer = new Lexer(text, langManager);
			
			var tokenList = new List<Token>();
			
			do
			{
				tokenList.Add(lexer.GetNextToken());
			} while (tokenList.Last().Type != TokenType.EOF);
			
			Assert.Equal(expectedTokens, tokenList);
		}

		[Fact]
		public void Test_Lexer_TokenStreamEn3()
		{
			var langManager = new LanguageManager();
			var expectedTokens = new List<Token>
			{
				new Token(TokenType.IF, "if"),
				new Token(TokenType.ELSE, "else"),
				new Token(TokenType.Identifier, "ifShouldBeId"),
				new Token(TokenType.TIMES, "times"),
				new Token(TokenType.UNTIL, "until"),
				new Token(TokenType.EOF, null)
			};

			const string text = "if else ifShouldBeId times until";
			var lexer = new Lexer(text, langManager);
			
			var tokenList = new List<Token>();
			
			do
			{
				tokenList.Add(lexer.GetNextToken());
			} while (tokenList.Last().Type != TokenType.EOF);
			
			Assert.Equal(expectedTokens, tokenList);
		}
		
		[Fact]
		public void Test_Lexer_TokenStreamEn4()
		{
			var langManager = new LanguageManager();
			var expectedTokens = new List<Token>
			{
				new Token(TokenType.TEXT, "text"),
				new Token(TokenType.Identifier, "str"),
				new Token(TokenType.Assign, "="),
				new Token(TokenType.TextLit, "wooah\"stillInString\nnew line"),
				new Token(TokenType.EOF, null)
			};

			const string text = "text str = \"wooah\\\"stillInString\\nnew line\"";
			var lexer = new Lexer(text, langManager);
			
			var tokenList = new List<Token>();
			
			do
			{
				tokenList.Add(lexer.GetNextToken());
			} while (tokenList.Last().Type != TokenType.EOF);
			
			Assert.Equal(expectedTokens, tokenList);
		}

        [Fact]
        public void Test_Lexer_TokenStreamEn5()
        {
			var langManager = new LanguageManager();
			var expectedTokens = new List<Token>
			{
				new Token(TokenType.Identifier, "having"),
				new Token(TokenType.NL, "\n"),
				new Token(TokenType.Identifier, "fun"),
				new Token(TokenType.XOR, "^"),
				new Token(TokenType.XOR, "^"),
				new Token(TokenType.BitAnd, "&"),
				new Token(TokenType.BitAnd, "&"),
				new Token(TokenType.Pow, "**"),
				new Token(TokenType.Mult, "*"),
				new Token(TokenType.RPar, ")"),
				new Token(TokenType.RPar, ")"),
			};

			const string text = "having \nfun ^^ && ***))";
			var lexer = new Lexer(text, langManager);

			var tokenList = new List<Token>();

			do
			{
				tokenList.Add(lexer.GetNextToken());
			} while (tokenList.Last().Type != TokenType.EOF);

			Assert.Equal(expectedTokens, tokenList);
		}


        [Fact]
		public void Test_Lexer_TokenStreamRo()
		{
			var langManager = new LanguageManager("ro");
			var expectedTokens = new List<Token>
			{
				new Token(TokenType.NUMBER, "numar"),
				new Token(TokenType.Identifier, "real"),
				new Token(TokenType.IF, "daca"),
				new Token(TokenType.ELSEIF, "altfel daca"),
				new Token(TokenType.WHILE, "cat timp"),
				new Token(TokenType.TEXT, "text"),
				new Token(TokenType.UNTIL, "pana cand"),
				new Token(TokenType.EOF, null)
			};
			const string text = "numar real daca altfel daca cat timp text pana cand";
			var lexer = new Lexer(text, langManager);
			
			var tokenList = new List<Token>();
			
			do
			{
				tokenList.Add(lexer.GetNextToken());
			} while (tokenList.Last().Type != TokenType.EOF);
			
			Assert.Equal(expectedTokens, tokenList);
			
		}
	}
}