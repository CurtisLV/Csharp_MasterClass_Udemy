﻿using System.Diagnostics.CodeAnalysis;

public class PetEqualityByIdComparer : IEqualityComparer<Pet>
{
    public bool Equals(Pet x, Pet y)
    {
        return x.Id == y.Id;
    }

    public int GetHashCode([DisallowNull] Pet pet)
    {
        return pet.Id;
    }
}
