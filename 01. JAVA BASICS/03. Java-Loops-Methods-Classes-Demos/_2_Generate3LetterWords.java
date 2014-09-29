package Lection3;

import java.util.Scanner;


public class _2_Generate3LetterWords {

	public static void main(String[] args) {
		System.out.print("Please enter one letter or more: ");
		Scanner scanner = new Scanner(System.in);
		char[] charArr = scanner.next().toCharArray();
		for (char first : charArr) {
		for (char second : charArr) {
		for (char third : charArr) {
		System.out.printf("%c%c%c ", first, second, third);

				}
			}
		}

	}

}
