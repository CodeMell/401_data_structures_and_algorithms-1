using System;
using System.Collections.Generic;

namespace CodeChallenges
{
  public class Animal
  {
    public string Species { get; set; }
    public string Name { get; set; }

    public Animal(string species, string name)
    {
      Species = species;
      Name = name;
    }
  }

  public class AnimalShelter
  {
    private Queue<Animal> animalsQueue;

    public AnimalShelter()
    {
      animalsQueue = new Queue<Animal>();
    }

    public void Enqueue(Animal animal)
    {
      animalsQueue.Enqueue(animal);
    }

    public Animal Dequeue(string pref)
    {
      if (pref != "dog" && pref != "cat")
      {
        return null;
      }

      // Find the first animal with the preferred species in the queue
      foreach (var animal in animalsQueue)
      {
        if (animal.Species == pref)
        {
          animalsQueue = new Queue<Animal>(animalsQueue); // To keep the queue intact while removing the animal
          animalsQueue.Dequeue(); // Remove the animal from the front of the queue
          return animal; // Return the animal with the preferred species
        }
      }

      return null; // Return null if no animal with the preferred species is found
    }
  }
}
