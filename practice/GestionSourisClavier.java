// Nom: 	Janie Berube
// Date: 	2024-02-13
// Description: Exercice de capture de clavier et de souris
// Instructions:
/*
 * 	-Si on dactylographie, les touches doivent se concaténer à notre chaine.
	-Si vous appuyez sur le bouton droit de la souris dans l’espace du JPanel, 
	     votre chaîne doit s’effacer et lorsque vous recommencez à dactylographier 
	     la nouvelle chaîne devra débuter à l’endroit où vous venez juste de cliquer.
	-Si on appuie sur « backspace » votre chaîne doit s’effacer un caractère à la fois.
	-Vous pouvez aussi déplacer le texte avec l'aide des flèches du clavier.  V
	-Vous devez déplacer votre chaine de 10 pixels à chaque clique sur les flèches. 
*/

package exercices_prog;

import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;

import java.awt.Point;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;


//*A noter que les valeurs des boutons pour la souris sont potentiellement differents des miens 

public class GestionSourisClavier extends JPanel implements KeyListener, MouseListener {
	private String chaine;
	private Point pClic;
	
	public GestionSourisClavier() {
		JFrame frame = new JFrame(); // JFrame est la fenetre principale
		this.setPreferredSize(new Dimension(600, 600));// ajustement de la taille du JPanel w * h
		frame.add(this);
		this.addKeyListener(this);
		this.addMouseListener(this);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // lors du clique sur le X
		frame.pack();
		frame.setVisible(true);
		
		
		this.setFocusable(true);
		this.requestFocus();
		chaine = "Programmation et Applications Mobiles";
		pClic = new Point(20, 20);
		
		
	}

	@Override
	protected void paintComponent(Graphics g) {
		super.paintComponent(g);
		Font font = new Font("Arial", Font.PLAIN, 22);
		g.setFont(font);
		g.drawString(chaine, pClic.x, pClic.y);
	}

	
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {

				GestionSourisClavier win = new GestionSourisClavier();
			}
		});
	}

	@Override
	//Backspace (effacer un caractère a la fois)
	public void keyTyped(KeyEvent e) {
		if (e.getKeyChar() == KeyEvent.VK_BACK_SPACE) {		
			if (!chaine.isEmpty() ) {
				chaine = chaine.substring(0, chaine.length() - 1);
			}
			else {
				chaine += e.getKeyChar();
			}
		}
		else {
			char caractere = e.getKeyChar();
			chaine = chaine + caractere;
		}
		repaint();
	}

	@Override
	// Déplacement du texte avec les flêches du clavier
	public void keyPressed(KeyEvent e) {
		if(e.getKeyCode() == KeyEvent.VK_RIGHT) {
			pClic.x += 10;
		}
		else if (e.getKeyCode() == KeyEvent.VK_LEFT) {
			pClic.x -= 10;
		}
		
		else if (e.getKeyCode() == KeyEvent.VK_UP) {
			pClic.y -= 10;
		}
		
		else if (e.getKeyCode() == KeyEvent.VK_DOWN) {
			pClic.y += 10;
		}
	
		repaint();
	}



	@Override
	// Effacer la chaine au clic droit de la souris
	public void mouseClicked(MouseEvent e) {

		if (e.getButton() == MouseEvent.BUTTON3) { 	// Clique droit
			chaine = "";
			pClic.x = e.getX();
			pClic.y = e.getY();
		}
		repaint();
	}

	@Override
	public void keyReleased(KeyEvent e) {}
	
	@Override
	public void mousePressed(MouseEvent e) {}

	@Override
	public void mouseReleased(MouseEvent e) {}

	@Override
	public void mouseEntered(MouseEvent e) {}

	@Override
	public void mouseExited(MouseEvent e) {}
			
}
