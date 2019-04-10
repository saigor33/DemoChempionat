create table users(
	users_id int unsigned unique not null auto_increment,
    users_login varchar(80) unique not null,
    users_password varchar(80) unique not null,
    users_post Enum('Заказчик','Менеджер','Кладовщик','Директор'),
    primary key (users_login)
);

create table rulons (
	 rulons_id int unsigned  not null,
     rulons_idSpecific int unsigned not null,
	-- rulons_id varchar(80) unique not null,
    rulons_composition varchar(80) not null,
    rulons_color varchar(80)  not null,
    rulons_width float unsigned not null,
     rulons_lenght float unsigned not null,
	primary key(rulons_id,rulons_idSpecific)
);

create table items (
	items_id int unsigned not null auto_increment,
    items_rulonsId int unsigned  not null,
    items_rulonsIdSpecific int unsigned  not null,
    items_name varchar(80),
    items_width float unsigned not null,
    items_lenght float unsigned not null,
    items_count int unsigned not null,
    
    primary key(items_id, items_rulonsId,items_rulonsIdSpecific),
    foreign key  (items_rulonsId)  references rulons(rulons_id)
    on update cascade
    on delete cascade
);

create table orders (
	orders_id int unsigned not null auto_increment,
    orders_userId int unsigned not null,
    
    orders_itemsId int unsigned not null,
    orders_rulonsId int unsigned not null,
     orders_rulonsIdSpecific int unsigned not null,
    orders_countItems int unsigned not null,
    
    primary key (orders_id),
	foreign key (orders_userId) references users(users_id) on update cascade on delete cascade,
    foreign key(orders_itemsId) references items (items_id) on update cascade on delete cascade,
    foreign key (orders_rulonsId) references rulons (rulons_id) on update cascade on delete cascade
);

