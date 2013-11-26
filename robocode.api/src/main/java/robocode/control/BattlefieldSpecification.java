/*******************************************************************************
 * Copyright (c) 2001-2013 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/epl-v10.html
 *******************************************************************************/
package robocode.control;


/**
 * Defines the size of a battlefield, which is a part of the {@link BattleSpecification}.
 *
 * @see BattleSpecification#BattleSpecification(int, BattlefieldSpecification, RobotSpecification[])
 * @see BattleSpecification#BattleSpecification(int, long, double, BattlefieldSpecification, RobotSpecification[])
 * @see BattleSpecification#getBattlefield()
 *
 * @author Mathew A. Nelson (original)
 * @author Flemming N. Larsen (contributor)
 */
public interface BattlefieldSpecification extends java.io.Serializable {
  
	int getWidth();

	int getHeight();

	
}
