/*
 * Nom:				Janie Bérubé
 * Date:			2024-03-14
 * Description:		Exercice AnimalRace - Multithreading avec Java 
 * 
 * Instructions: Pour simuler une course, AnimalRace utilisera un thread pour faire les déplacements, 
 * de cette façon on pourra faire démarrer plusieurs animaux à la fois.
 * Chaque animal devra s'avoir sa distance présente.
 * Un animal devra courir tant et aussi longtemps qu'il n'a pas terminé sa course, donc tant que la distance 
 * parcourue est plus petite que la distance de la course.
 * Chaque animal devra dormir (sleep) durant un temps au hasard entre 500 et 1500 millisecondes.
 * Pour calculer son avancement (distance parcourue), chaque animal pourra avancer d'un nombre 
 * au hasard entre 1 et sa vitesse.  

 */

package exercices_prog;

import java.util.Random;

import thread.AnimalRacer;

public class AnimalRace extends Thread {
	
	private String type;
	private int vitesse;
	private int distance;
	Random randSleep = new Random();
	Random randDistance = new Random();
	private int distanceParcourue = 0;
	
	private static boolean aWinner = false;
	
	AnimalRace(String type, int vitesse, int distance) {
		this.type = type;
		this.vitesse = vitesse;
		this.distance = distance;
		start();
	}
	
	
	@Override
	public void run() {
		
		while (distanceParcourue < distance) {
			distanceParcourue += randDistance.nextInt(1, vitesse + 1);
			System.out.println(this.type + " : est a " + distanceParcourue + " m");
			
			try {
				Thread.sleep(randSleep.nextInt(500, 1501));
			}catch (InterruptedException ie) {
				ie.printStackTrace();
			}
		}
		if (!aWinner) {
			System.out.println("**********" + this.type + " a gagné**********");
			aWinner = true;
		}

		else 
			System.out.println("**********" + this.type + " a traversé la ligne**********");
	}
	
	public static void main(String[] args) {
		AnimalRace lapin = new AnimalRace("lapin", 9, 50);
		AnimalRace tortue = new AnimalRace("tortue", 8, 50);
		AnimalRace cheval = new AnimalRace("cheval", 10, 50);

	}
}
