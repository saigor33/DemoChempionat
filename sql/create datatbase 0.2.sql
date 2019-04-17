create table users(
	users_id int unsigned unique not null auto_increment,
    users_login varchar(80) unique not null,
    users_password varchar(80) not null,
    users_post Enum('Заказчик','Менеджер','Кладовщик','Директор') not null,
    users_contactTelephone varchar(11),
    primary key (users_login)
);

create table rulons (
	 rulons_id int unsigned  not null auto_increment,
     rulons_idSpecific int unsigned not null,
	-- rulons_id varchar(80) unique not null,
    rulons_composition varchar(80) not null,
    rulons_color varchar(80)  not null,
    rulons_width float unsigned not null,
     rulons_lenght float unsigned not null,
     rulons_price float unsigned not null,
     rulons_count int unsigned not null, -- отсутсвует в бд
	primary key(rulons_id,rulons_idSpecific)
);

create table use_rulon (
	 useRulon_id int unsigned  not null,
     useRulon_idSpecific int unsigned not null,
     useRulon_pointers MEDIUMTEXT not null,
	primary key(useRulon_id,useRulon_idSpecific),
    
    foreign key (useRulon_id,useRulon_idSpecific) references rulons(rulons_id,rulons_idSpecific) on update cascade on delete cascade 
);

create table delete_rulons (
	 deleteRulons_id int unsigned  not null auto_increment,
	deleteRulons_idRulons int unsigned  not null,
	deleteRulons_idSpecific int unsigned not null,
     useRulon_pointers MEDIUMTEXT not null,
     deleteRulons_status bool not null,
	primary key(deleteRulons_id),
    foreign key (deleteRulons_idRulons,deleteRulons_idSpecific) references rulons(rulons_id,rulons_idSpecific) on update cascade on delete cascade 
);

create table forniture (
	forniture_id int unsigned not null,
    forniture_name varchar(80) not null,
    forniture_weight float unsigned not null,
    forniture_weight1count float unsigned not null,
    forniture_price float unsigned not null,
    primary key(forniture_id)
);


create table materialsInstruction (
	materialsInstruction_id int unsigned not null auto_increment,
    materialsInstruction_rulonsId int unsigned not null ,
    materialsInstruction_rulonsIdSpecific int unsigned not null,
    materialsInstruction_rulonsWidth float unsigned not null,
    materialsInstruction_rulonsHeight float unsigned not null,
    
	materialsInstruction_fornitureId int unsigned not null ,
	materialsInstruction_fornitureCount int unsigned not null ,
	materialsInstruction_pointers mediumtext,
    
    primary key (materialsInstruction_id),
    foreign key (materialsInstruction_rulonsId,materialsInstruction_rulonsIdSpecific) references rulons(rulons_id,rulons_idSpecific) on update cascade on delete cascade,
    foreign key (materialsInstruction_fornitureId) references forniture(forniture_id) on update cascade on delete cascade
);

create table materialsInstructionHistory
(
	materialsInstructionHistory_id int unsigned not null auto_increment,
    
	materialsInstructionHistory_idMaterials int unsigned not null,
    materialsInstructionHistory_rulonsName int unsigned not null ,
    materialsInstructionHistory_rulonsWidth float unsigned not null,
    materialsInstructionHistory_rulonsHeight float unsigned not null,
    
	materialsInstructionHistory_fornitureName int unsigned not null ,
	materialsInstructionHistory_fornitureCount int unsigned not null ,
	materialsInstruction_pointers mediumtext,

    primary key (materialsInstructionHistory_id),
    foreign key (materialsInstructionHistory_idMaterials) references materialsInstruction(materialsInstruction_id) on update cascade on delete cascade
);


create table items (
	items_id int unsigned not null auto_increment,
    items_idMaterials int unsigned not null,
    items_name varchar(80),
    items_width float unsigned not null,
    items_lenght float unsigned not null,
    items_count int unsigned not null,
    items_price float unsigned not null,
    items_properties mediumtext,
    
    
    primary key(items_id),
    foreign key  (items_idMaterials)  references materialsInstruction(materialsInstruction_id)
   on update cascade
on delete cascade
);

create table orders (
	orders_id int unsigned not null auto_increment,
    orders_userId int unsigned not null,
    
    orders_itemsId int unsigned not null,
    orders_countItems int unsigned not null,
    orders_loginManager varchar(80),
    primary key (orders_id),
	foreign key (orders_userId) references users(users_id) on update cascade on delete cascade,
    foreign key(orders_itemsId) references items (items_id) on update cascade on delete cascade
);

