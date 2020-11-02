using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddnodeBalkan.TableTennis.Data;
using AddnodeBalkan.TableTennis.Models;
using AddnodeBalkan.TableTennis.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddnodeBalkan.TableTennis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("getplayers")]
        public IEnumerable<Player> GetPlayers()
        {
            try
            {
                return _playerService.GetAllPlayers();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("addplayer")]
        public IActionResult AddPlayer(Player player)
        {
            try
            {
                _playerService.AddPlayer(player);
                return Ok();
            }
            catch (Exception ex)
            {
                // do the logging, fire up 500
                throw ex;
            }
        }

        [HttpPost("updateplayer")]
        public IActionResult UpdatePlayer(Player player)
        {
            try
            {
                _playerService.UpdatePlayer(player);
                return Ok();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("deleteplayer")]
        public IActionResult DeletePlayer(int playerId)
        {
            try
            {
                _playerService.DeletePlayer(playerId);
                return Ok();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}