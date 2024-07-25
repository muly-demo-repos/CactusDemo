import { Module } from "@nestjs/common";
import { MYweirDcaPitaliZAtiOnService } from "./myweirdcapitalization.service";
import { MYweirDcaPitaliZAtiOnController } from "./myweirdcapitalization.controller";
import { MYweirDcaPitaliZAtiOnResolver } from "./myweirdcapitalization.resolver";

@Module({
  controllers: [MYweirDcaPitaliZAtiOnController],
  providers: [MYweirDcaPitaliZAtiOnService, MYweirDcaPitaliZAtiOnResolver],
  exports: [MYweirDcaPitaliZAtiOnService],
})
export class MYweirDcaPitaliZAtiOnModule {}
