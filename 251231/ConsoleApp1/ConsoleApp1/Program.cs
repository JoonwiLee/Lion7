using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 변수사용
			/*
			int age;
			age = 25;

			// Console.WriteLine(age); //주석처리 ctrl+k+c, 복구 ctrl+k+u

			int level;
			level = 100;

			Console.WriteLine("레벨: " + level);
			*/


			// 리터럴 사용
			/*
			int num = 10;
			double pi = 3.14;
			char letter = 'A';
			string name = "Alice";

			// Console.WriteLine(num);
			// Console.WriteLine(pi);
			// Console.WriteLine(letter);
			// Console.WriteLine(name);

			int 플레이스코어 = 100;
			double 파이 = 3.14;
			char 등급 = 'A';
			string 플레이어이름 = "홍길동";

			Console.WriteLine(플레이스코어 + " " + 파이 + " " + 등급 + " " + 플레이어이름);
			*/


			// 변수 선언 후 값 저장
			/*
			string greeting;
			greeting = "Hello, World!";
			//Console.WriteLine(greeting);

			//변수 선언+초기화
			int score = 100;
			double temperature = 36.5;
			string city = "seoul";

			Console.WriteLine(score + " " + temperature + " " + city);
			*/


			// 형식이 같은 변수 여러개
			/*
			int x = 10, y = 20, z = 30;
			string name = "abc";
			// Console.WriteLine(x + " " + y + " " + z);

			// Console.WriteLine("x = {0}, y = {1}, name = {2}", x, y, name);
			// Console.WriteLine($"x = {x}, y = {y}, name = {name}"); // 편의성 높아 자주 사용되는 출력방식
			*/


			// 여러가지 출력법
			/*
			int posX = 0, posY = 50, posZ = 100;
			Console.WriteLine("좌표 x = {0}, y = {1}, z = {2}", posX, posY, posZ);
			Console.WriteLine("좌표 x = " + posX + ", y = " + posY + ", z = " + posZ);
			Console.WriteLine($"좌표 x = {posX}, y = {posY}, z = {posZ}");
			
			int red = 255, green = 128, blue = 0;
			Console.WriteLine("색상 r = {0}, g = {2}, b = {1}", red, green, blue);
			Console.WriteLine("색상 r = " + red + ", g = " + green + ", b = " + blue);
			Console.WriteLine($"색상 r = {red}, g = {green}, b = {blue}");
			*/


			//

			Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━┓");
			Console.WriteLine("┃\t게임 시작\t┃");
			Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━┛");
		}
	}
}
