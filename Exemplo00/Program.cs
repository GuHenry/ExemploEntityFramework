using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaContext contexto = new SistemaContext();

            #region InserirAnimal
            Animal animal2 = new Animal();
            animal2.Nome = "TRex";
            animal2.Extinto = true;

            contexto.Animais.Add(animal2);
            contexto.SaveChanges();
            Console.WriteLine("Registro salvo com sucesso");
            #endregion InserirAnimal

            #region Apagar
            //Animal animalApagar = contexto.Animais.Where(x => x.Nome == "Porco aranha").First();
            //contexto.Animais.Remove(animalApagar);
            //contexto.SaveChanges();
            #endregion Apagar

            #region Atualizar
            //var zebra = contexto.Animais.Where(x => x.Id == 4).First();
            //zebra.Nome = "zebrinha";
            //contexto.SaveChanges();
            #endregion Atualizar

            #region Selecionar
            List<Animal> animais = contexto.Animais.ToList();
            foreach(Animal animal in animais)
            {
                Console.WriteLine($"{animal.Id} - {animal.Nome} - {animal.Extinto}");
            }
            #endregion Selecionar

            #region InserirHabilidade
            Habilidade habilidade = new Habilidade();
            habilidade.IdAnimal = 1;
            habilidade.Nome = "Invisibilidade";

            contexto.Habilidades.Add(habilidade);
            contexto.SaveChanges();

            var habilidades = contexto.Habilidades.Include("Animal").ToList();

            foreach (Habilidade habilidadeAux in habilidades)
            {
                Console.WriteLine(habilidade.Nome);
            }
            #endregion InserirHabilidade




        }
    }
}
