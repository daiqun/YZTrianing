
INSERT INTO `role`(`name`, `display_name`) VALUES('SysAdmin', '系统管理员') ;
INSERT INTO `role`(`name`, `display_name`) VALUES('ContentAdmin', '考试管理员') ;
INSERT INTO `role`(`name`, `display_name`) VALUES('Teacher', '教师') ;
INSERT INTO `role`(`name`, `display_name`) VALUES('Student', '学生') ;

INSERT INTO `permission`(`name`, `display_name`) VALUES('create_user', '新增用户') ;
INSERT INTO `permission`(`name`, `display_name`) VALUES('delete_user', '删除用户') ;
INSERT INTO `permission`(`name`, `display_name`) VALUES('update_user', '修改用户信息') ;

INSERT INTO `role_permission`(`role_id`, `permission_id`) VALUES(1, 1) ;
INSERT INTO `role_permission`(`role_id`, `permission_id`) VALUES(1, 2) ;
INSERT INTO `role_permission`(`role_id`, `permission_id`) VALUES(1, 3) ;

INSERT INTO `user`( `user_name`, `password`, `create_time`, `update_time` ) VALUES( 'william.dai', '123456', NOW(), NOW() ) ;

INSERT INTO `user_role`(`user_id`, `role_id`) VALUES(1, 1) ;