import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { MyEntItyService } from "./myEntIty.service";
import { MyEntItyControllerBase } from "./base/myEntIty.controller.base";

@swagger.ApiTags("myEntIties")
@common.Controller("myEntIties")
export class MyEntItyController extends MyEntItyControllerBase {
  constructor(
    protected readonly service: MyEntItyService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
