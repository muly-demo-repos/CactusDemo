import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { DefService } from "./def.service";
import { DefControllerBase } from "./base/def.controller.base";

@swagger.ApiTags("defs")
@common.Controller("defs")
export class DefController extends DefControllerBase {
  constructor(
    protected readonly service: DefService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
