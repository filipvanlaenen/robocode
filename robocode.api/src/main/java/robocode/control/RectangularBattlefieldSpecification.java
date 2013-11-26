package robocode.control;

public class RectangularBattlefieldSpecification implements BattlefieldSpecification {
	private static final String TIMES = "×";

	private static final long serialVersionUID = 1L;

	private final int width;
	private final int height;

	/**
	 * Creates a standard 800 x 600 battlefield.
	 */
	public RectangularBattlefieldSpecification() {
		this(800, 600);
	}

	/**
	 * Creates a battlefield of the specified width and height.
	 *
	 * @param width  the width of the battlefield, where 400 <= width <= 5000.
	 * @param height the height of the battlefield, where 400 <= height <= 5000.
	 * @throws IllegalArgumentException if the width or height < 400 or > 5000.
	 */
	public RectangularBattlefieldSpecification(int width, int height) {
		if (width < 400 || width > 5000) {
			throw new IllegalArgumentException("width must be: 400 <= width <= 5000");
		}
		if (height < 400 || height > 5000) {
			throw new IllegalArgumentException("height must be: 400 <= height <= 5000");
		}

		this.width = width;
		this.height = height;
	}

	/**
	 * Returns the width of this battlefield.
	 *
	 * @return the width of this battlefield.
	 */
	public int getWidth() {
		return width;
	}

	/**
	 * Returns the height of this battlefield.
	 *
	 * @return the height of this battlefield.
	 */
	public int getHeight() {
		return height;
	}

	public static BattlefieldSpecification parseProperty(String property) {
	int times = property.indexOf(TIMES);
	String widthString = property.substring(0, times);
	String heightString = property.substring(times + 1);
	return new RectangularBattlefieldSpecification(Integer.parseInt(widthString), Integer.parseInt(heightString));
		
	}

	@Override
	public String toProperty() {
			return width + TIMES +height;
	}
}
