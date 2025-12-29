using UnityEngine;
using System.Collections.Generic;

public class DNA_sc : MonoBehaviour
{
    List<int> genes=new List<int>();
    int dnaLength=0;
    int maxValues=0;

    public DNA_sc(int length,int maxV)
    {
        this.dnaLength=length;
        this.maxValues=maxV;
        SetRandom();
    }
    
    public void Mutate()
    {
        this.genes[Random.Range(0,this.dnaLength)]=Random.Range(0,this.maxValues);
    }

    public void SetRandom()
    {
        genes.Clear();

        for(int i = 0; i < dnaLength; i++)
        {
            genes.Add(Random.Range(0,maxValues));
        }
    }

    public void SetInt(int pos,int value)
    {
        genes[pos]=value;
    }

    public int GetGene(int pos)
    {
        return this.genes[pos];
    }

    public void Combine(DNA_sc d1,DNA_sc d2)
    {
        for(int i = 0; i <this.dnaLength; i++)
        {
            if (i <this.dnaLength / 2.0f)
            {
                int c=d1.genes[i];
                this.genes[i]=c;
            }

            else
            {
                int c=d2.genes[i];
                this.genes[i]=c;
            }
            
        }
    }
}
