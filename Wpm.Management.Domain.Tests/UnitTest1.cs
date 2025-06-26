namespace Wpm.Management.Domain.Tests;

public class UnitTest1
{
    [Fact]
    public void Pet_Should_be_equale()
    {
        var id = Guid.NewGuid();

        var pet1 = new Pet(
            id,
            "Giana",
            12,
            "three-color",
            new Weight(20.5m),
            SexOfPet.Male);



        var pet2 = new Pet(
            id,
            "Nina",
            10,
            "three-color",
            new Weight(18.5m),
            SexOfPet.Female);




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

        var pet1 = new Pet(
            id,
            "Giana",
            12,
            "three-color",
            new Weight(20.5m),
            SexOfPet.Male);



        var pet2 = new Pet(
            id,
            "Nina",
            10,
            "three-color",
            new Weight(18.5m),
            SexOfPet.Female);


        Assert.True(pet1 == pet2);
    }



    [Fact]
    public void Pet_should_not_be_equal_using_operators()
    {
        var id1 = Guid.NewGuid();
        var id2 = Guid.NewGuid();

        var pet1 = new Pet(
                id1,
                "Giana",
                12,
                "three-color",
                new Weight(20.5m),
                SexOfPet.Male);



        var pet2 = new Pet(
            id2,
            "Nina",
            10,
            "three-color",
            new Weight(18.5m),
            SexOfPet.Female);



        Assert.True(pet1 != pet2);
    }


    [Fact]
    public void Weight_should_be_equale()
    {
        var w1 = new Weight(20.5m);
        var w2 = new Weight(20.5m);

        Assert.True(w1 == w2);
    }
}
