create table items
(
	id int identity primary key,
	name varchar(50) unique not null,
	description varchar(140) default '...',
	item_image image,
)

create table items_recipe
(
	id int identity primary key,
	id_craftable int references items(id),
	id_crafting_item int references items(id),
)

create table players
(
	id int identity primary key,
	name varchar(50) unique not null,
)

create table inventories
(
	id int identity primary key,
	id_player int not null references players(id),
	id_item int not null references items(id),
	item_count int not null default 0 check(item_count >= 0),
)

create index idx_items_name on items(name);
create index idx_players_name on players(name);

create view list_items as (select * from items);
create view list_items_recipe as (select * from items_recipe);
create view list_players as (select * from players);
create view list_inventories_items as (select * from inventories);
