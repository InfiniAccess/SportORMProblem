// Level 1 - 1
// ViewBag.League = _context.Leagues
//               .Where(n => n.Name.Contains("Women"))
//               .ToList();

// Level 1 - 2
// ViewBag.League = _context.Leagues
//                 .Where(l => l.Sport.Contains("Hockey"))
//                 .ToList();

// Level 1 - 3
// ViewBag.League = _context.Leagues
//                 .Where(l => !l.Sport.Contains("Football"))
//                 .ToList();

// Level 1 - 4
// ViewBag.League = _context.Leagues
//                 .Where(l => l.Name.Contains("Conference"))
//                 .ToList();

// Level 1 - 5
// ViewBag.League = _context.Leagues
//                 .Where(l => l.Name.Contains("Atlantic"))
//                 .ToList();

// Level 1 - 6
// ViewBag.AllTeam = _context.Teams
//                 .Where(t => t.Location.Contains("Dallas"))
//                 .ToList();

// Level 1 - 7
// ViewBag.AllTeam = _context.Teams
//                 .Where(t => t.TeamName.Contains("Raptors"))
//                 .ToList();

// Level 1 - 8
// ViewBag.AllTeam = _context.Teams
//                 .Where(t => t.Location.Contains("City"))
//                 .ToList();

// Level 1 - 9
// ViewBag.AllTeam = _context.Teams
//                 .Where(t => t.TeamName.StartsWith("T"))
//                 .ToList();

// Level 1 - 10
// ViewBag.AllTeam = _context.Teams
//                 .OrderBy(t => t.TeamName)
//                 .ToList();

// Level 1 - 11
// ViewBag.AllTeams = _context.Teams
//                 .OrderByDescending(t => t.TeamName)
//                 .ToList();

// Level 1 - 12
// ViewBag.PlayerStuff = _context.Players
//                 .Where(t => t.LastName.Contains("Cooper"))
//                 .ToList();

// Level 1 - 13
// ViewBag.PlayerStuff = _context.Players
//                 .Where(t => t.FirstName.Contains("Joshua"))
//                 .ToList();

// Level 1 - 14
// ViewBag.PlayerStuff = _context.Players
//                 .Where(t => t.LastName.Contains("Cooper") && !t.FirstName.Contains("Joshua"))
//                 .ToList();

// Level 1 - 15
// ViewBag.PlayerStuff = _context.Players
//                 .Where(t => t.FirstName.Contains("Alexander") || t.FirstName.Contains("Wyatt"))
//                 .ToList();