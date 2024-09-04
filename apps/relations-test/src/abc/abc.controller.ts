import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { AbcService } from "./abc.service";
import { AbcControllerBase } from "./base/abc.controller.base";

@swagger.ApiTags("abcs")
@common.Controller("abcs")
export class AbcController extends AbcControllerBase {
  constructor(
    protected readonly service: AbcService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
