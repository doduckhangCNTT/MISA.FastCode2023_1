<template>
  <div class="misa-button flex" >
    <slot name="button"></slot>
    <slot name="combobox"></slot>
  </div>
</template>

<script>
export default {
  name:"MISAButton",
}
</script>

<style>
  @import url("./MISAButton.css");
</style>