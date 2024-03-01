package computergraphics;

import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Informe a velocidade do projétil: ");
		double velocidade = scanner.nextDouble();
		
		System.out.print("Informe a distância em kms que o projétil percorreu: ");
		int distancia = scanner.nextInt();		
		
		double velocidadeMedia = velocidade / distancia;
		
		System.out.println("A velocidade média é de " + String.valueOf(velocidadeMedia));

		scanner.close();
	}
}
