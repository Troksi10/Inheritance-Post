using Inheritance_Post;

Post post1 = new Post("Thanks for the birth wishes",true,"Ilija Trokovski");
Console.WriteLine(post1.ToString());

ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Ilija Trokovski", "https://images.com/shoes", true);
Console.WriteLine(imagePost1.ToString());


Console.ReadLine();
