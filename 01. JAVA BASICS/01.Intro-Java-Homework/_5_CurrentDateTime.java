package Lection1;

import java.time.LocalDateTime;

public class _5_CurrentDateTime {
	public static void main(String[] args) {
		
		LocalDateTime dt = LocalDateTime.now();
		System.out.println("The current date and time is " + dt);
	}
}

