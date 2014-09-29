package Lection4;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
public class _08_ExtractEmails {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String text = sc.nextLine();
		Pattern emailPattern = Pattern.compile("[\\w]+[\\.-]*[\\w]+@[A-Za-z-]+-*[A-Za-z]\\.[A-Za-z]+\\.*[A-Za-z]+");
		Matcher matcher = emailPattern.matcher(text);
		while (matcher.find()) {
			System.out.println(matcher.group());
		}
		sc.close();
	}
}
