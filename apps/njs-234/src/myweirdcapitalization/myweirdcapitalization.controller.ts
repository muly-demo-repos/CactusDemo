import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as errors from "../errors";
import { MYweirDcaPitaliZAtiOnService } from "./myweirdcapitalization.service";

@swagger.ApiTags("mYweirDcaPitaliZAtiOns")
@common.Controller("mYweirDcaPitaliZAtiOns")
export class MYweirDcaPitaliZAtiOnController {
  constructor(protected readonly service: MYweirDcaPitaliZAtiOnService) {}

  @common.Get("/:id/my-ca-pitalized-ac-tion")
  @swagger.ApiOkResponse({
    type: String
  })
  @swagger.ApiNotFoundResponse({
    type: errors.NotFoundException
  })
  @swagger.ApiForbiddenResponse({
    type: errors.ForbiddenException
  })
  async MyCaPitalizedAcTion(
    @common.Body()
    body: string
  ): Promise<string> {
        return this.service.MyCaPitalizedAcTion(body);
      }
}
