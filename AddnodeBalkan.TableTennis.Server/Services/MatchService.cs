using AddnodeBalkan.TableTennis.Data.Repository;
using AddnodeBalkan.TableTennis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddnodeBalkan.TableTennis.Services
{
    public class MatchService : IMatchService
    {
        private readonly MatchRepository matchRepository;

        public MatchService()
        {
            matchRepository = new MatchRepository();
        }

        public void AddMatch(Match match)
        {
            try
            {
                matchRepository.Add(match);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteMatch(Match match)
        {
            try
            {
                matchRepository.Delete(match);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Match> GetMatches()
        {
            try
            {
                return matchRepository.Get();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateMatch(Match match)
        {
            try
            {
                matchRepository.Update(match);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
