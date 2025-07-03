using Wpm.Management.Domain.Entiities;
using Wpm.Management.Domain.ValueObjects;

namespace Wpm.Management.Domain.Tests;

public class UnitTest1
{
    [Fact]
    public void Pet_Should_be_equale()
    {
        var id = Guid.NewGuid();
        var breedService = new FakeBreedService();
        var breedId = new BreedId(breedService.breeds[0].Id, breedService);


        var pet1 = new Pet(
            id,
            "Giana",
            12,
            "three-color",
            new Weight(20.5m),
            SexOfPet.Male,
            breedId);



        var pet2 = new Pet(
            id,
            "Nina",
            10,
            "three-color",
            new Weight(18.5m),
            SexOfPet.Female,
            breedId);




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

        var breedService = new FakeBreedService();
        var breedId = new BreedId(breedService.breeds[0].Id, breedService);

        var pet1 = new Pet(
            id,
            "Giana",
            12,
            "three-color",
            new Weight(20.5m),
            SexOfPet.Male,
            breedId);



        var pet2 = new Pet(
            id,
            "Nina",
            10,
            "three-color",
            new Weight(18.5m),
            SexOfPet.Female,
            breedId);


        Assert.True(pet1 == pet2);
    }


    [Fact]
    public void Pet_should_not_be_equal_using_operators()
    {
        var breedService = new FakeBreedService();
        var breedId = new BreedId(breedService.breeds[0].Id, breedService);


        var id1 = Guid.NewGuid();
        var id2 = Guid.NewGuid();

        var pet1 = new Pet(
                id1,
                "Giana",
                12,
                "three-color",
                new Weight(20.5m),
                SexOfPet.Male,
                breedId);



        var pet2 = new Pet(
            id2,
            "Nina",
            10,
            "three-color",
            new Weight(18.5m),
            SexOfPet.Female,
            breedId);



        Assert.True(pet1 != pet2);
    }


    [Fact]
    public void Weight_should_be_equale()
    {
        var w1 = new Weight(20.5m);
        var w2 = new Weight(20.5m);

        Assert.True(w1 == w2);
    }

 
    [Fact]
    public void BreedId_should_be_valid()
    {
        var breedService = new FakeBreedService();
        var id = breedService.breeds[0].Id;
        var breedId = new BreedId(id, breedService);
        Assert.NotNull(breedId);

    }

    [Fact]
    public void BreedId_should_not_be_valid()
    {
        var breedService = new FakeBreedService();
        var id = Guid.NewGuid();

        Assert.Throws<ArgumentException>(() =>
        {
            var breedId = new BreedId(id, breedService);

        });

    }
}