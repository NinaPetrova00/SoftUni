using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    private Hero hero;
    private HeroRepository data;
    [SetUp]
    public void SetUp()
    {
        hero = new Hero("Ivan", 5);
        data = new HeroRepository();
    }


    [Test]
    public void Ctor_ValidData()
    {
        Assert.That(data, Is.Not.Null);
    }

    [Test]
    public void Create_ThrowException_WhenHeroIsNull()
    {
        Hero hero = null;
        Assert.Throws<ArgumentNullException>(() => data.Create(hero));
    }

    [Test]
    public void Create_ThrowException_WhenNameAlreadyExists()
    {
        data.Create(hero);

        Assert.Throws<InvalidOperationException>(() => data.Create(hero));
    }

    [Test]
    public void Remove_ThrowException_WhenNameIsNull()
    {
        string heroName = null;

        Assert.Throws<ArgumentNullException>(() => data.Remove(heroName));
    }

    [Test]
    public void Remove_ReturnFalse()
    {
        string heroName = "Gosho";

        Assert.IsFalse(data.Remove(heroName));
    }

    [Test]
    public void Remove_ReturnTrue()
    {
        string heroName = "Gosho";
        data.Remove(heroName);
        Assert.IsFalse(data.Remove(heroName));
    }

    [Test]
    public void GetHeroWithHighestLevel_()
    {
        Hero hero2 = new Hero("Gosho", 500);
       
        data.Create(hero);
        data.Create(hero2);

        Assert.That(hero2, Is.EqualTo(data.GetHeroWithHighestLevel()));
    }

    [Test]
    public void GetHero_()
    {
        data.Create(hero);

        Assert.That(hero, Is.EqualTo(data.GetHero(hero.Name)));
    }
   
}