public class Restaurant {
	public int rating;
	public string name;
	public int numberOfReviews;
	
	public void getRating() {
		MessageBox.Show("The overall rating of this restaurant is " + rating);
	}

	public void getName() {
		MessageBox.Show("The name of the restaurant is " + name);
	}

	public void reportNumber()
    {
        MessageBox.Show("The number of reviews are " + numberOfReviews);
    }
}