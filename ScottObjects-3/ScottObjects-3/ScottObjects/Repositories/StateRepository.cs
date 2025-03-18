using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects.Repositories
{
    public class StateRepository : ICrudOps<State>
    {
        private static readonly List<State> States = new List<State>();

        public void Create(State entity)
        {
            if (States.Any(s => s.Id == entity.Id))
            {
                Console.WriteLine($"State with ID {entity.Id} already exists.");
                return;
            }
            States.Add(entity);
            Console.WriteLine($"State added: {entity}");
        }

        public State Read(int id)
        {
            var state = States.FirstOrDefault(s => s.Id == id);
            if (state == null)
            {
                Console.WriteLine($"State with ID {id} not found.");
            }
            return state;
        }

        public IEnumerable<State> ReadAll()
        {
            return States;
        }

        public void Update(State entity)
        {
            var state = States.FirstOrDefault(s => s.Id == entity.Id);
            if (state == null)
            {
                Console.WriteLine($"State with ID {entity.Id} not found.");
                return;
            }
            state.StateName = entity.StateName;
            state.StateCode = entity.StateCode;
            Console.WriteLine($"State updated: {entity}");
        }

        public void Delete(int id)
        {
            var state = States.FirstOrDefault(s => s.Id == id);
            if (state == null)
            {
                Console.WriteLine($"State with ID {id} not found.");
                return;
            }
            States.Remove(state);
            Console.WriteLine($"State deleted: {state}");
        }
    }

}
