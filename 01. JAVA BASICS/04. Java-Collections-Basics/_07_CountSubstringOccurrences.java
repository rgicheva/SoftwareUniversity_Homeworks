package Lection4;

import java.util.Scanner;

public class _07_CountSubstringOccurrences {

	public static void main(String[] args) {
		System.out.println("Please enter some text:");
		Scanner scan = new Scanner(System.in);
		String text = scan.nextLine();
		String targetWord = scan.nextLine();
		targetWord = targetWord.toLowerCase();
		String[] textArray = text.split("\\W+");
		int count = 0;
		for(int i = 0; i < textArray.length; i++) {
			String temp = textArray[i].toLowerCase();
			int firstPosition = temp.indexOf(targetWord);
			if(firstPosition != -1) {
				count++;
				temp = temp.substring(firstPosition + targetWord.length(), temp.length());
			}
		}
		System.out.println(count);
		scan.close();

	}

}
