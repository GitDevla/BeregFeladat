Készíts konzolos alkalmazást, amely a https://infojegyzet.hu/webszerkesztes/mysql/pizza/ oldalon lévő 23-28 kérdésekre kiírja a választ!
Jelenítsd meg a kérdés számát és szövegét is !

Beadandó a project GitHub linkje



-- Melyik a legdrágább pizza?
SELECT pnev, par FROM pizza ORDER BY par DESC LIMIT 1;

-- Ki szállította házhoz a legtöbb pizzát?
SELECT fnev, Count(DISTINCT razon) cunt FROM futar JOIN rendeles USING(fazon) GROUP BY fazon ORDER BY cunt DESC LIMIT 1;

-- Ki ette a legtöbb pizzát?
SELECT vnev, Sum(db)som FROM vevo JOIN rendeles USING(vazon) JOIN tetel USING(razon) GROUP BY vazon ORDER BY som DESC LIMIT 1; 