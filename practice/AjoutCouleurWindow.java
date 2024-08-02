/*
 * Nom:				Janie Bérubé
 * Date:			2024-03-18
 * Description:		Exercice AjoutCouleurWindow
 */

package exercices_prog;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.GridLayout;
import java.awt.Toolkit;
import java.awt.datatransfer.Clipboard;
import java.awt.datatransfer.StringSelection;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.AdjustmentEvent;
import java.awt.event.AdjustmentListener;

import javax.swing.*;

public class AjoutCouleurWindow extends JFrame implements AdjustmentListener, ActionListener {

	// Declarations / initializations
	private int redInt = 168;
	private int greenInt = 255;
	private int blueInt = 79;
	
	private static final int MIN_VALUE = 0;
	private static final int MAX_VALUE = 256;
	
	private JPanel pColorPanel = new JPanel();
	private JPanel pLabelPanel = new JPanel();
	private JPanel pButtonPanel = new JPanel();
	
	private String title = "RGB(" + String.valueOf(redInt) + "," + String.valueOf(greenInt) + "," +
			String.valueOf(blueInt) + ")";
	
	private Color bgColor = new Color(redInt, greenInt, blueInt);
	
	private JLabel redLabel = new JLabel("Red     : " + String.valueOf(redInt));
	private JLabel greenLabel = new JLabel("Green : " + String.valueOf(greenInt));
	private JLabel blueLabel = new JLabel("Blue    : " + String.valueOf(blueInt));
	
	private JScrollBar redSB = new JScrollBar(JScrollBar.HORIZONTAL, redInt, 1, MIN_VALUE, MAX_VALUE);
	private JScrollBar greenSB = new JScrollBar(JScrollBar.HORIZONTAL, greenInt, 1, MIN_VALUE, MAX_VALUE);
	private JScrollBar blueSB = new JScrollBar(JScrollBar.HORIZONTAL, blueInt, 1, MIN_VALUE, MAX_VALUE);
	
	private JButton copyButton = new JButton("Copier dans le presse-papier");
	private JButton changeButton = new JButton("Changer la couleur");
	
	
	
	public AjoutCouleurWindow() {
		
		// Methods
		createControls();
		addControlsToPanels();
		
		// Events
		redSB.addAdjustmentListener(this);
		greenSB.addAdjustmentListener(this);
		blueSB.addAdjustmentListener(this);
		copyButton.addActionListener(this);
		changeButton.addActionListener(this);
	}
	
	public void createControls() {
		
		// Settings JFrame
		this.setTitle(title);
		this.setSize(300, 300);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setVisible(true);
		
		pColorPanel.setBackground(bgColor);
		
	}
	
	public void addControlsToPanels() {
		
		JPanel pControls = new JPanel();
		pControls.setLayout(new GridLayout(2,1));
		
		// Add labels and scrollBars to panel
		pLabelPanel.setLayout(new GridLayout(3, 2));
		pLabelPanel.add(redLabel);
		pLabelPanel.add(redSB);
		pLabelPanel.add(greenLabel);
		pLabelPanel.add(greenSB);
		pLabelPanel.add(blueLabel);
		pLabelPanel.add(blueSB);
		
		// Add buttons to panel
		pButtonPanel.setLayout(new GridLayout(2,1, 0, 10));
		pButtonPanel.add(copyButton, BorderLayout.SOUTH);
		pButtonPanel.add(changeButton, BorderLayout.SOUTH);
		
		// Add panels to JFrame
		pControls.add(pColorPanel);
		pControls.add(pLabelPanel);
		pControls.add(pButtonPanel);
		
		this.add(pColorPanel, BorderLayout.CENTER);
		this.add(pControls, BorderLayout.SOUTH);
	}

	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			@Override
			public void run() {
				AjoutCouleurWindow win = new AjoutCouleurWindow();
			}
		});

	}
	
	public void updateColor() {
		
		//Background
		pColorPanel.setBackground(bgColor);
		
		// Title
		title = "RGB(" + String.valueOf(redInt) + "," + String.valueOf(greenInt) + "," +
				String.valueOf(blueInt) + ")";
		this.setTitle(title);
		
		// Labels
		redLabel.setText("Red     : " + String.valueOf(redInt));
		greenLabel.setText("Green : " + String.valueOf(greenInt));
		blueLabel.setText("Blue    : " + String.valueOf(blueInt));
		
		// Scrollbars
		redSB.setValue(redInt);
		greenSB.setValue(greenInt);
		blueSB.setValue(blueInt);
		
		pColorPanel.repaint();
	}

	@Override
	public void adjustmentValueChanged(AdjustmentEvent e) {
		if (e.getSource() == redSB)
		
			redInt = redSB.getValue();
		else if (e.getSource() == greenSB)
			greenInt = greenSB.getValue();
		else 
			blueInt = blueSB.getValue();
		
		bgColor = new Color(redInt, greenInt, blueInt);
		
		updateColor();
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		
		//Copy
		if (e.getSource() == copyButton) {
			String copyColorString = "rgb(" + String.valueOf(redInt) + "," + String.valueOf(greenInt) +
					"," + String.valueOf(blueInt) + ")";
			
			StringSelection copySelection = new StringSelection(copyColorString);
			
			Clipboard clip = Toolkit.getDefaultToolkit().getSystemClipboard();
			
			clip.setContents(copySelection, copySelection);
		}

		
		//Change
		else {
			Color newColor = JColorChooser.showDialog(null, "Choisir une couleur", bgColor);	
			
			if (newColor != null) {
				bgColor = newColor;
				redInt = bgColor.getRed();
				greenInt = bgColor.getGreen();
				blueInt = bgColor.getBlue();
				updateColor();
			}
		}
	}

}