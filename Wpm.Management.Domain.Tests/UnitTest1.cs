namespace Wpm.Management.Domain.Tests;

public class UnitTest1
{
    [Fact]
    public void Pet_Should_be_equale()
    {
        var id = Guid.NewGuid();

        var pet1 = new Pet(id)
        {
            Name = "Gianni", 
            Age = 13 
        };


        var pet2 = new Pet(id);
      

        /* This will clearly lead to a failing unit test 
         The main point to emphasize I have the ability to modify the unique Identifier of this object
        We will fix this issue my implementing a constructor and ensuring that the Id propery will only be initialized while 
        constructing the object. */
        // => pet1.Id = Guid.NewGuid(); 


        Assert.True(pet1.Equals(pet2));

    }

    [Fact]
    public void Pet_should_be_equal_using_operators()
    {
        var id = Guid.NewGuid();

        var pet1 = new Pet(id);


        var pet2 = new Pet(id); 
       

        Assert.True(pet1 == pet2);
    }



    [Fact]
    public void Pet_should_not_be_equal_using_operators()
    {
        var id1 = Guid.NewGuid();
        var id2 = Guid.NewGuid();


        var pet1 = new Pet(id1);


        var pet2 = new Pet(id2);



        Assert.True(pet1 != pet2);
    }

}
